//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Generated from: steammessages_site_license.steamclient.proto
// Note: requires additional types generated from: steammessages_unified_base.steamclient.proto
namespace SteamKit2.Unified.Internal
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSiteLicense_ClientSiteAssociation_Notification")]
  public partial class CSiteLicense_ClientSiteAssociation_Notification : global::ProtoBuf.IExtensible
  {
    public CSiteLicense_ClientSiteAssociation_Notification() {}
    

    private byte[] _site_association_file = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"site_association_file", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] site_association_file
    {
      get { return _site_association_file; }
      set { _site_association_file = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    public interface ISiteLicense
    {
      NoResponse ClientSiteAssociation(CSiteLicense_ClientSiteAssociation_Notification request);
    
    }
    
    
}
#pragma warning restore 1591
