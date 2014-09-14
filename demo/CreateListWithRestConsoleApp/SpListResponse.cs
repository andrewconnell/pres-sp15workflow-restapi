using System;

namespace ConsoleApplication1 {

  public class SpList {
    public SpListResponse d { get; set; }
  }

  public class SpListResponse {
    public SpListMetadata __metadata { get; set; }
    public Firstuniqueancestorsecurableobject FirstUniqueAncestorSecurableObject { get; set; }
    public Roleassignments RoleAssignments { get; set; }
    public Contenttypes ContentTypes { get; set; }
    public Defaultview DefaultView { get; set; }
    public Eventreceivers EventReceivers { get; set; }
    public Fields Fields { get; set; }
    public Forms Forms { get; set; }
    public Informationrightsmanagementsettings InformationRightsManagementSettings { get; set; }
    public Items Items { get; set; }
    public Parentweb ParentWeb { get; set; }
    public Rootfolder RootFolder { get; set; }
    public Usercustomactions UserCustomActions { get; set; }
    public Views Views { get; set; }
    public Workflowassociations WorkflowAssociations { get; set; }
    public bool AllowContentTypes { get; set; }
    public int BaseTemplate { get; set; }
    public int BaseType { get; set; }
    public bool ContentTypesEnabled { get; set; }
    public DateTime Created { get; set; }
    public string DefaultContentApprovalWorkflowId { get; set; }
    public string Description { get; set; }
    public string Direction { get; set; }
    public string DocumentTemplateUrl { get; set; }
    public int DraftVersionVisibility { get; set; }
    public bool EnableAttachments { get; set; }
    public bool EnableFolderCreation { get; set; }
    public bool EnableMinorVersions { get; set; }
    public bool EnableModeration { get; set; }
    public bool EnableVersioning { get; set; }
    public string EntityTypeName { get; set; }
    public bool ForceCheckout { get; set; }
    public bool HasExternalDataSource { get; set; }
    public bool Hidden { get; set; }
    public string Id { get; set; }
    public string ImageUrl { get; set; }
    public bool IrmEnabled { get; set; }
    public bool IrmExpire { get; set; }
    public bool IrmReject { get; set; }
    public bool IsApplicationList { get; set; }
    public bool IsCatalog { get; set; }
    public bool IsPrivate { get; set; }
    public int ItemCount { get; set; }
    public DateTime LastItemDeletedDate { get; set; }
    public DateTime LastItemModifiedDate { get; set; }
    public string ListItemEntityTypeFullName { get; set; }
    public bool MultipleDataList { get; set; }
    public bool NoCrawl { get; set; }
    public string ParentWebUrl { get; set; }
    public bool ServerTemplateCanCreateFolders { get; set; }
    public string TemplateFeatureId { get; set; }
    public string Title { get; set; }
  }

  public class SpListMetadata {
    public string id { get; set; }
    public string uri { get; set; }
    public string etag { get; set; }
    public string type { get; set; }
  }

  public class Firstuniqueancestorsecurableobject {
    public __Deferred __deferred { get; set; }
  }

  public class __Deferred {
    public string uri { get; set; }
  }

  public class Roleassignments {
    public __Deferred1 __deferred { get; set; }
  }

  public class __Deferred1 {
    public string uri { get; set; }
  }

  public class Contenttypes {
    public __Deferred2 __deferred { get; set; }
  }

  public class __Deferred2 {
    public string uri { get; set; }
  }

  public class Defaultview {
    public __Deferred3 __deferred { get; set; }
  }

  public class __Deferred3 {
    public string uri { get; set; }
  }

  public class Eventreceivers {
    public __Deferred4 __deferred { get; set; }
  }

  public class __Deferred4 {
    public string uri { get; set; }
  }

  public class Fields {
    public __Deferred5 __deferred { get; set; }
  }

  public class __Deferred5 {
    public string uri { get; set; }
  }

  public class Forms {
    public __Deferred6 __deferred { get; set; }
  }

  public class __Deferred6 {
    public string uri { get; set; }
  }

  public class Informationrightsmanagementsettings {
    public __Deferred7 __deferred { get; set; }
  }

  public class __Deferred7 {
    public string uri { get; set; }
  }

  public class Items {
    public __Deferred8 __deferred { get; set; }
  }

  public class __Deferred8 {
    public string uri { get; set; }
  }

  public class Parentweb {
    public __Deferred9 __deferred { get; set; }
  }

  public class __Deferred9 {
    public string uri { get; set; }
  }

  public class Rootfolder {
    public __Deferred10 __deferred { get; set; }
  }

  public class __Deferred10 {
    public string uri { get; set; }
  }

  public class Usercustomactions {
    public __Deferred11 __deferred { get; set; }
  }

  public class __Deferred11 {
    public string uri { get; set; }
  }

  public class Views {
    public __Deferred12 __deferred { get; set; }
  }

  public class __Deferred12 {
    public string uri { get; set; }
  }

  public class Workflowassociations {
    public __Deferred13 __deferred { get; set; }
  }

  public class __Deferred13 {
    public string uri { get; set; }
  }

}
