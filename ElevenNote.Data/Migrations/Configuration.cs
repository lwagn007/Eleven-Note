namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ElevenNote.Data;

    internal sealed class Configuration : DbMigrationsConfiguration<ElevenNote.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ElevenNote.Data.ApplicationDbContext";
        }

        protected override void Seed(ElevenNote.Data.ApplicationDbContext context)
        {
            var notes = new List<Note>
            {
                new Note{OwnerID = Guid.NewGuid(), Title = "Hello Note", Content = "What's Note", CreatedUtc = DateTime.Now },
                new Note{OwnerID = Guid.NewGuid(), Title = "Hello Note", Content = "What's Note", CreatedUtc = DateTime.Now },
                new Note{OwnerID = Guid.NewGuid(), Title = "Hello Note", Content = "What's Note", CreatedUtc = DateTime.Now },
                new Note{OwnerID = Guid.NewGuid(), Title = "Hello Note", Content = "What's Note", CreatedUtc = DateTime.Now },
            };

            notes.ForEach(n => context.Notes.Add(n));
            context.SaveChanges();
        }
    }
}
