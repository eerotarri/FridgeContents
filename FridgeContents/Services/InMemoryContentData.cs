using FridgeContents.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FridgeContents.Services
{
    public class InMemoryContentData : IContentData
    {
        List<Content> contents;

        public InMemoryContentData()
        {
            contents = new List<Content>()
            {
                new Content { Id = 1, Name = "Kalja", Quantity = 4 },
                new Content { Id = 2, Name = "Voi", Quantity = 2 },
                new Content { Id = 3, Name = "Ketsuppi", Quantity = 1 },
                new Content { Id = 4, Name = "Muikku", Quantity = 6 },
            };
        }

        public void Add(Content content)
        {
            contents.Add(content);
            content.Id = contents.Max(r => r.Id) + 1;
        }

        public void Update(Content content)
        {
            var existing = Get(content.Id);
            if (existing != null)
            {
                existing.Name = content.Name;
                existing.Quantity = content.Quantity;
            }
        }

        public Content Get(int id)
        {
            return contents.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Content> GetAll()
        {
            return contents.OrderBy(c => c.Name);
        }

        public void Delete(int id)
        {
            var content = Get(id);
            if (content != null)
            {
                contents.Remove(content);
            }
        }
    }
}
