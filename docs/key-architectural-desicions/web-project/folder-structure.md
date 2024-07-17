The folder structure of a project matters because it makes the project much esier to navigate and understand. No one wants to spend 10 minutes trying to find their API hook and then another 10 minutes trying to find the page they want.
Instead we create folders grouped by their overarching usage. For example, we have a src folder (or "source" folder) under our Web project to hold all of our projects while outside of that we have our sln file (which stores our Solution - hence sln - that Visual Studio uses to store our API project).
This way we have seperation between what is used for the application and supporting materials such as docs (which you are reading right now), Azure or Git flows, our .gitignore, and our README