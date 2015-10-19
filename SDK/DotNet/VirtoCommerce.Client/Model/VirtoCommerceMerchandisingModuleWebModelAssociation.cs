using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;



namespace VirtoCommerce.Client.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class VirtoCommerceMerchandisingModuleWebModelAssociation {
    
    /// <summary>
    /// Gets or sets the value of catalog item association description
    /// </summary>
    /// <value>Gets or sets the value of catalog item association description</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    public string Description { get; set; }

    
    /// <summary>
    /// Gets or sets the value of catalog item id for current association
    /// </summary>
    /// <value>Gets or sets the value of catalog item id for current association</value>
    [DataMember(Name="itemId", EmitDefaultValue=false)]
    public string ItemId { get; set; }

    
    /// <summary>
    /// Gets or sets the value of catalog item association name
    /// </summary>
    /// <value>Gets or sets the value of catalog item association name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// Gets or sets the numeric value of catalog item association priority
    /// </summary>
    /// <value>Gets or sets the numeric value of catalog item association priority</value>
    [DataMember(Name="priority", EmitDefaultValue=false)]
    public int? Priority { get; set; }

    
    /// <summary>
    /// Gets or sets the value of catalog item association type
    /// </summary>
    /// <value>Gets or sets the value of catalog item association type</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    public string Type { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VirtoCommerceMerchandisingModuleWebModelAssociation {\n");
      
      sb.Append("  Description: ").Append(Description).Append("\n");
      
      sb.Append("  ItemId: ").Append(ItemId).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Priority: ").Append(Priority).Append("\n");
      
      sb.Append("  Type: ").Append(Type).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}


}