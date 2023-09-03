using BotSharp.Abstraction.Routing.Models;

namespace BotSharp.Abstraction.Repositories.Records;

public class RoutingItemRecord : RecordBase
{
    public string AgentId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<string> RequiredFields { get; set; } = new List<string>();
    public string? RedirectTo { get; set; }
    public bool Disabled { get; set; }

    public RoutingItem ToRoutingItem()
    {
        return new RoutingItem
        {
            AgentId = AgentId,
            Name = Name,
            Description = Description,
            RequiredFields = RequiredFields,
            RedirectTo = RedirectTo,
            Disabled = Disabled
        };
    }

    public static RoutingItemRecord FromRoutingItem(RoutingItem item)
    {
        return new RoutingItemRecord
        {
            AgentId = item.AgentId,
            Name = item.Name,
            Description = item.Description,
            RequiredFields = item.RequiredFields,
            RedirectTo = item.RedirectTo,
            Disabled = item.Disabled
        };
    }
}
