using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CalicotGaming.Web.Models;

// dotnet add package Azure.AI.OpenAI --version 1.0.0-beta.5
using Azure;
using Azure.AI.OpenAI;

namespace CalicotGaming.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly CalicotGamingDbContext _context;
        private readonly IConfiguration _config;

        public ProductsController(CalicotGamingDbContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
              return _context.Products != null ? 
                          View(await _context.Products.ToListAsync()) :
                          Problem("Entity set 'CalicotGamingDbContext.Products'  is null.");
        }


        // GET: Products/Assistant
        // NOTE: In a real-world scenario, I'd have created a ChatService class with an IChatService interface and put that code into it.
        // But for the sake of the demo, I kept it here to reduce the number of back and forth between code artefacts when explaining the code.
        // SAMPLE QUESTIONS: 
        // - what gaming console do you recommend for less than 200$? 
        // - Recommend a racing game for the Xbox
        public async Task<IActionResult> Assistant(string promptText)
        {
            if(string.IsNullOrEmpty(promptText))
            {
                return View(new ChatModel());
            }

            OpenAIClient client = new OpenAIClient(
            new Uri(_config["AzureOpenAI:aoaiEndpoint"]),
            new AzureKeyCredential(_config["AzureOpenAI:aoaiKey"]));
            
            Response<ChatCompletions> responseWithoutStream = await client.GetChatCompletionsAsync(
            "gpt-35-turbo",
            new ChatCompletionsOptions()
            {
                Messages =
                {
                    new ChatMessage(ChatRole.System, _config["AzureOpenAI:systemRoleMessage"]),
                    new ChatMessage(ChatRole.User, promptText)     
                },
                Temperature = (float)0.7,
                MaxTokens = 800,
                NucleusSamplingFactor = (float)0.95,
                FrequencyPenalty = 0,
                PresencePenalty = 0,
            });

            ChatCompletions response = responseWithoutStream.Value;

            var model = new ChatModel
            {
                Prompt = promptText,
                Completion = response.Choices[0].Message.Content
            };

            return View("Assistant", model);
        }

/*
        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,PhotoUrl,Description")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,PhotoUrl,Description")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Products == null)
            {
                return Problem("Entity set 'CalicotGamingDbContext.Products'  is null.");
            }
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
          return (_context.Products?.Any(e => e.Id == id)).GetValueOrDefault();
        }
*/
    }
}
