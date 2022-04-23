namespace SuggestionAppLibrary.Models;

public class SuggestionModel
{

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Suggestion { get; set; }
    public string Description { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.UtcNow; // Coordinated Universal Time (UTC).
    public CategoryModel Category { get; set; }
    public BasicUserModel Author { get; set; }
    public HashSet<string> UserVotes { get; set; } = new(); // HashSet is an unordered collection of unique elements.
    public StatusModel Status { get; set; }
    public string OwnerNotes { get; set; }
    public bool ApprovedForRelease { get; set; } = false;
    public bool Archived { get; set; } = false;
    public bool Rejected { get; set; } = false;
}