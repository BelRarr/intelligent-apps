intelligent-apps
===

Demonstrating how to integrate Azure AI services into existing applications.

# The Goal
The purpose of this demo is to show how to integrate Azure AI services into a previously modernized web application. 

# The Demo
We'll take a basic shopping site application (consisting of a web application and a SQL database) and integrate Azure OpenAI and Azure AI Search into it so visitors can chat with the product catalog rather than using filters or relying on full-text search to get the most relevant items for their queries.

# This branch demonstrates ...
How to implement grounded chat using RAG. In this scenario, the chatbot will still rely on the GPT 3.5 Turbo model but its responses will be constrained (grounded) to the data that is in the database.

The relevant code files are:
* `ProductsController.cs`: where the code to interact with both Azure OpenAI AND Azure AI Search is implemented. look for the "Assistant" Action.
* `Views/Products/Index.cshtml`: where we offer users to either scroll through the product catalog or to interact with the AI assistant.
* `Views/Products/Assistant.cshtml`: where the chat interaction happens. Look for the system role message in the appsettings.json file and see how the AI assistant can't answer questions that are outside of the scope of the Calicot Gaming world. E.g., it won't give you a recipe for a pizza ;)