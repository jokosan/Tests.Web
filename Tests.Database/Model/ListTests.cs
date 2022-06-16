using System.Collections.Generic;

namespace Tests.Database.Model
{
    public class ListTests
    {
        public int IdListTest { get; set; }
        public ICollection<Questions> Questions { get; set; }

        public string Name { get; set; }
        public string Note { get; set; }
        public string Img { get; set; }
        public bool StatusPublic { get; set; }
    }
}
