intelligent-apps
===

Demonstrating how to integrate Azure AI services into existing applications.

# The Goal
The purpose of this demo is to show how to integrate Azure AI services into a previously modernized web application. 

# The Demo
We'll take a basic shopping site application (consisting of a web application and a SQL database) and integrate Azure OpenAI and Azure AI Search into it so visitors can chat with the product catalog rather than using filters or relying on full-text search to get the most relevant items for their queries.

# This branch demonstrates ...
How to implement ungrounded chat. In this scenario, the chatbot will rely only on the GPT 3.5 Turbo model and its response will not be constrained (grounded) to the results of the database.

The relevant code files are:
* `ProductsController.cs`: where the code to interact with Azure OpenAI is implemented. look for the "Assistant" Action.
* `Views/Products/Index.cshtml`: where we offer users to either scroll through the product catalog or to interact with the AI assistant.
* `Views/Products/Assistant.cshtml`: where the chat interaction happens.