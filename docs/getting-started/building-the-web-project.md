# Building the Initial Web Project

Wether you create the repo locally first and post to Github or Azure is up to your personal preference, however I would recommend creating the repo in which ever cloud repo you are using (in the case of this project, it's Github).

When creating your first application is often helpful to start first with your web project. I would reccommend using Vite as it is much lighter and faster than using npm, using yarn as your package manager, and React as your framework.

## Building the Web App

1. To use Vite to build your project, simply run: `yarn create vite`

   If you do not have yarn installed, you can go [here](https://yarnpkg.com/getting-started/install) to install it.

1. Now give your project a name. If this is a personal project, codenames are always a fun option. If this is a professional application, I reccomend following this pattern roughly as a guide:
   <br><br>
   Company or Project.Application Type/Domain.Web
   <br><br>
   Example: Apple.Portal.Web or Apple.AppStore.Web

1. Choose React as your Framework
1. Choose TypeScript (not TypeScript + JWC) as your variant

Viola! Now you have a web project

## Setup Prettier and ESLint

ES Lint and Prettier are tools meant to help developers keep their code clean, readable, and effective while following certain formatting rules. Gone are the days of having to manually check that every file has the exact number of indents and spaces required by your company or ensuring semicolons after every line.

Prettier can be configured so that each time you save your files, the formatting rules will automatically be applied, changing you code format as necessary. ES Lint is an incredibly useful tool in ensureing you are following proper conventions required by either your own standards or those of a client or company. Often times linters also enforce

1. To install prettier simply run: `yarn add prettier --dev`

   <br>
   You can also install the extension which might be helpful:

   ![alt text](image-2.png)

   ![alt text](image-1.png)

1. Then create a .prettierrc file with your prettier settings.

1. For ESLint install the VS Code extension (below) and change the name of the `.eslintrc.cjs` file to `.eslintrc.json`.

   ![alt text](image.png)

1. Then replace its contents with your settings.

If you are unsure which settings to put in either file or if you do not have your own, you can copy from this project!

## First Commit

Once you have your initial web project completed, you are ready for your first commit! Be warned, the only time it is ever acceptable to push to main is when you are setting up the project. When following proper [CICD](../core-principles/cicd-principles.md) conventions, you normally have short lived feature branches that get reviewed and pulled into main. You should enforce rules that prevent anyone from committing directly to main and only allow changes to main through pull requests that are reviewed by 1-2 peers or collegues including someone with more experiece than you if possible. This should be one of the first things you do either after your initial project setup or before even cloning the repo to your machine.

This way, if a bug or breaking change is introduced you can walk back your latest PR and search for bugs without leaving your application completely useless or broken. This also allows you to learn faster by having any mistakes or missing pieces pointed out and corrected directly or by giving you an opportunity to just bounce ideas off of others. For more information see [here](../core-principles/trunk-based-development.md).
