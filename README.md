intelligent-apps
===

Demonstrating how to integrate Azure AI services into existing applications.

# The Goal
The purpose of this demo is to show how to integrate Azure AI services into a previously modernized web application. 

# The Demo
We'll take a basic shopping site application (consisting of a web application and a SQL database) and integrate Azure OpenAI and Azure AI Search into it so visitors can chat with the product catalog rather than using filters or relying on full-text search to get the most relevant items for their queries.

# This branch demonstrates ...
How to implement full text search.
The relevant code files are:
* `ProductsController.cs`: especially the `Search` action.
* `Views/Products/Index.cshtml`: where the search bar is designed.
* `Views/Products/Search.cshtml`: where the search results are presented.
