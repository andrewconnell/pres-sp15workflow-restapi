Overview
========
- [Understanding SharePoint 2013 Workflow](#understanding-sharepoint-2013-workflow)
- [SharePoint Designer 2013 + SharePoint 2013 REST API](#sharepoint-designer-2013--sharepoint-2013-rest-api)
- [Visual Studio 2013 + SharePoint 2013 REST API](#visual-studio-2013--sharepoint-2013-rest-api)



Understanding SharePoint 2013 Workflow
======================================
- Workflow engine no longer *inside* SharePoint
- Now *outsourced* from SharePoint to Workflow Manager
  - Workflow Manager is a new product
- WM & SP communicate over HTTPS via REST API, secured using OAuth2 (S2S)
- Works the same way in Office 365 & on-premises



SharePoint activities & actions use REST
----------------------------------------
- SharePoint-specific activities run in Workflow Manager
- Access SharePoint via SharePoint's REST API 



Custom workflows can call REST web services
-------------------------------------------
- Entire SharePoint 2013 REST API available in workflows
- Requires some extra permission work
- SharePoint Designer 2013 authored workflows aren't apps
  - Extra manual configuration required
- Removes all restrictions with OOTB actions & activities



Common Scenarios
----------------
- Create sites
- Create lists & libraries
- Manage permissions



SharePoint Designer 2013 + SharePoint 2013 REST API
===================================================
- SPD'13 authored workflows
  - Do not have permissions to use SharePoint's REST API
  - Are not apps & thus have no special permissions
- SPD'13 has a new **App Step** action, but site must allow it's use



Steps to elevate SPD'13 authored workflows
------------------------------------------
1. Activate the site feature **Workflows can use app permission**
1. Register the workflow as an app with extra permissions:

    ````xml
    <AppPermissionRequests>
        <AppPermissionRequest Scope="http://sharepoint/content/sitecollection/web" 
                              Right="FullControl" />
    </AppPermissionRequests>
    ````

1. Trust the new app with extra permissions 
1. Wrap workflow action in **App Step**



DEMO: Use SPD'13 to Call SP'13 REST API
---------------------------------------

![crazy demo](img/demo01.gif)



But wait... consider the use case...
------------------------------------
- SharePoint Designer 2013 is targeted to:
  - End / power users
  - No-code customizations



Is SPD'13 the right tool? ... for the right audience?
-----------------------------------------------------

![wrong tool](img/wrongTool.jpg)



Visual Studio 2013 + SharePoint 2013 REST API
=============================================
- Hardest part: getting the call just right
- **Recommendation:** crate console app that does everything
  - Use as the model for creating the workflow



Common things you'll do
-----------------------
- Get the HostWeb URL
- Get the S2S token to authenticate
- Obtain a security digest (aka: form digest)



DEMO: Create a List in the HostWeb
----------------------------------
![demo](img/demo02.gif)



Resources
=========
- [Pluralsight: SharePoint 2013 Workflow - Web Services: Module 3 "Workflows & Working with the SharePoint 2013 REST API"](http://pluralsight.com/training/Courses/TableOfContents/sharepoint-2013-workflow-web-services)
- [MSDN: Create a workflow with elevated permissions by using the SharePoitn 2013 Workflow platform](http://msdn.microsoft.com/en-us/library/office/jj822159.aspx)
- [GitHub: ExecuteSPRestApi by Alex Randall (Microsoft)](https://github.com/alex-randall/Office365WorkflowScenarios/tree/master/src/ExecuteSPRestApi)