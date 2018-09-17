# webapicore-sample

This is just a sample in order to showcase Azure DevOps build and release Pipelines

1. Create a new Project on AzureDevOps;
2. Clone this repository into the newly created project
3. Create a Build Pipeline using the "ASP.NET" template
4. On the Build Pipeline check the "Enable continuous integration" flag on the Triggers tab
5. On the Azure portal create a new Web App
6. Create a Release Pipeline using the "Azure App Service Deployment" template
8. Fill out the required fields using the Azure subscription where you created the Web App
7. On the Release Pipeline add the artifact from the previously created Build Definition
8. Enable the "Continuous deployment trigger" on the artifact
9. Create a new Build and monitor the pipelines
10. Make a change on the code and see the pipelines triggering
