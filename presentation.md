Custom SharePoint 2013 Workflows that use theSharePoint 2013 REST API
=====================================================================
*Follow along at [github.com/andrewconnell/pres-sp15-workflow-restapi](http://github.com/andrewconnell/pres-sp15-workflow-restapi)!*



h1
========================
- bla bla bla
- bla bla bla



h2
---------------------------------------
- bla bla bla
- bla bla bla
- bla bla bla

````javascript
var requestUri = _spPageContextInfo.webAbsoluteUrl +'/_api/Web/Lists'
  +'/getByTitle(\'Contacts\')/items/?'
  +'$select=Id,FirstName,Title,Email';

// execute AJAX request
var requestHeaders = { 'accept': 'application/json;odata=verbose' };

jQuery.ajax({
  url: requestUri,
  headers: requestHeaders,
  success: function (response){ /* do something on success */ },
  error: function(error){ /* do something on fail */ }
});

````



>#Resources
- bla bla bla
- bla bla bla
- bla bla bla
- bla bla bla
