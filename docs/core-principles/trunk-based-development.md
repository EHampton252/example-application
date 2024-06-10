Trunk based development is a development methodology where developers create short lived "feature" branches where small incremental changes are made, reviewed, and pulled into a "main" or trunk branch.

In the world of software consulting this most often looks like a client asking for an application with features A, B, and C with an agreed upon timeline. As the team begins work, each piece of a feature is created on a seperate branch which is tested and reviewed before being pulled into "main" which is the current working state of the product.

For example, lets say Dev 1 is working on an API call for Feature A. Once he believes this call is complete and has tested it completely, he will create a "Pull Request" which allows Devs 2 and 3 to review his work and ensure he did not miss anything and is following proper standards laid out earlier by the client and project team. Once Devs 2 and 3 agree that Dev 1's PR (Pull Request) is as it should be,then they approve the PR and Dev 1 can merge his branch into main.

This effectively adds a new piece of functionality to the appplication. In the event that this PR breaks the application or causes significant errors, the branch can simply be reverted, fixed, re-reviewed, and pulled back into main. This way the application's functionality is not interrupted for long and can be quickly restablished in working order while the team fixes any issues.

There should also be some level of CICD?? checks with automatic testing, linting, and building of the project to ensure there are no build errors before the pull request is completed. This should be done with every pull request as well as team code reviews to help reduce the likelyhood that a PR that breaks main will go through.
