using FridgeContents.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeContents.Services
{
    public interface IContentData
    {
        IEnumerable<Content> GetAll();
        Content Get(int id);
        void Add(Content content);
        void Update(Content content);
        void Delete(int id);
    }
}
