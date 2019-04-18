using System.Runtime.Serialization;

namespace Fourth_Task.Models
{
    [DataContract]
    public class UserViewModel
    {
        [DataMember(Name = "id")]
        public long Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "lastName")]
        public string LastName { get; set; }

        [DataMember(Name = "isEditMode")]
        public bool IsEditMode { get; set; }
    }
}
