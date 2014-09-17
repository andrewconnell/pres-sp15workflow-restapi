SharePoint Designer Demo Steps
==============================
> Notes from my demo for creating a workflow in SharePoint Designer 2013 that calls the SharePoint 2013 REST API to create a list. The are just notes, not complete steps. 
> 
> If you want to see the whole demo, checkout my course on Pluralsight: :moneybag: [SharePoint 2013 Workflow - Web Services](http://pluralsight.com/training/Courses/TableOfContents/sharepoint-2013-workflow-web-services), specifically module 3. The demo of this is from the clip :moneybag: [DEMO: Create Lists with SharePoint's List OData (REST) API](http://pluralsight.com/training/Courses/TableOfContents/sharepoint-2013-workflow-web-services). Please keep in mind, Pluralsight is not free... it's behind a paywall. 


Create list
-----------
- Title
- BaseTemplateID
- New List URL

Enable the site so workflows treated as apps
--------------------------------------------
- Create workflow & notice that the App Step is not enabled
- Site Settings > Site App Permissions = nothing listed… need workflow to treated like app
- Site Features > Activate Workflows can use app permissions
- Site Settings > Site App Permissions = copy the first GUID OUT
- /_layouts/15/appinv.aspx - register an app principal for workflow & give it permissions
   - ID = GUID just got
   - Click LOOKUP
   - Permissions
   - <AppPermissionRequests><AppPermissionRequest Scope="http://sharepoint/content/sitecollection/web" Right="FullControo"/></>
- SPD - verify app step is there

Create workflow
---------------

Variables: 
   - SecurityDigest(string)
   - NewListURL(string)
   - ODataRequestHeaders(Dictionary)
   - ODataRequestPayload(Dictionary)
   - ODataResponseBody(Dictionary)
   - ODataRequestEndpoint(string)

###STAGE: Obtain Security Digest
- Build Dictionary > ODataRequestHeaders
   - ACCEPT = application/json;odata=verbose
   - CONTENT-LENGTH=0
- AppStep
   - ODataRequestEndpoint = WORKFLOWCONTENXT-CURRENTSITEURL/_api/contextinfo
   - CALL HTTP WEB SERVICE
      - URL = ODataRequestEndpoint
      - METHOD = POST
      - PROPERTIES
         - RequestHeaders = ODataRequestHeaders
         - ResponseContent = ODataResponseBody
- Get from dictionary
   - SecurityDigest = d/GetWebContextInformation/FormDigestValue from ODataResponseBody

###STAGE: Create List using REST API
- Build Dictionary = new = ListPayloadMetadata
   - type=SP.List (string)
- Build Dictonary = ODataRequstPayload
   - __metadata (dictionary) = ListPayloadMetadata
   - Title = Title field of the list item
   - BaseTemplate = ListTemplateId in list item
- Build Dictionary > ODataRequestHeaders
   - ACCEPT = application/json;odata=verbose
   - CONTENT-LENGTH=0
- App Step
   - ODataRequestEndpoint = WORKFLOWCONTEXT-CURRENTSITEURL/_api/web/lists
- Call HTTP Web Service
   - URL = ODataRequestEndpoint
   - METHOD = POST
   - Properties
      - RequestHeaders = ODataRequestHeaders
      - RequestContent = ODataRequestPayload
      - ResponseContent = ODataResponseBody

###STAGE: Update List Item with New List URL
- Get Item from Dictionary
   - NewListURL = d/__metadata/id from ODataResponseBody
- Build Dictionary > ODataRequestHeaders
   - ACCEPT = application/json;odata=verbose
- ODataRequestEndpoint = NewListURL/DefaultView
- Call HTTP Web Service
   - URL = ODataRequestEndpoint
   - Properties
      - RequestHeaders = ODataRequestHeaders
      - ResponseContent = ODataResponseBody
- Get Item from Dictionary
   - NewListURL = d/ServerRelativeUrl from ODataResponseBody
- remove leading "/" form URL
   - Extract Substring from Index of String
      - Copy from NewListURL starting at 1 = NewListURL
- Set Field in Current Item
   - New List URL = NewListURL