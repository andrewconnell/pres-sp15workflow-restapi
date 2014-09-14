namespace ConsoleApplication1 {

  public class SpContextInfo {
    public SpContextInfoResponse d { get; set; }
  }

  public class SpContextInfoResponse {
    public Getcontextwebinformation GetContextWebInformation { get; set; }
  }

  public class Getcontextwebinformation {
    public SpContextInfoMetadata __metadata { get; set; }
    public int FormDigestTimeoutSeconds { get; set; }
    public string FormDigestValue { get; set; }
    public string LibraryVersion { get; set; }
    public string SiteFullUrl { get; set; }
    public Supportedschemaversions SupportedSchemaVersions { get; set; }
    public string WebFullUrl { get; set; }
  }

  public class SpContextInfoMetadata {
    public string type { get; set; }
  }

  public class Supportedschemaversions {
    public string[] results { get; set; }
  }
}
