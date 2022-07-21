using FridgeContents.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FridgeContents.Services
{
    public class SqlContentData : IContentData
    {
        private readonly FridgeContentsDbContext db;

        public SqlContentData(FridgeContentsDbContext db)
        {
            this.db = db;
        }

        public void Add(Content content)
        {
            db.Contents.Add(content);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var content = db.Contents.Find(id);
            db.Contents.Remove(content);
            db.SaveChanges();
        }

        public Content Get(int id)
        {
            return db.Contents.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Content> GetAll()
        {
            return db.Contents;
        }

        public void Update(Content content)
        {
            var entry = db.Entry(content);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}