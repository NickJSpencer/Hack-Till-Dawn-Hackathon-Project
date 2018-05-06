using HackTillDawnProject.Data;
using HackTillDawnProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTillDawnProject.Services
{
    public interface IBasicModelService<T>
    {
        T Add(T add, bool save_after_execute = true);
        void Add(List<T> adds, bool save_after_execute = true);

        T Update(T update, bool save_after_execute = true);
        void Update(List<T> updates, bool save_after_execute = true);

        T FlagForDelete(T delete, bool save_after_execute = true);
        void FlagForDelete(List<T> deletes, bool save_after_execute = true);

        T Activate(T activate, bool save_after_execute = true);
        void Activate(List<T> activates, bool save_after_execute = true);

        T Deactivate(T deactivate, bool save_after_execute = true);
        void Deactivate(List<T> deactivates, bool save_after_execute = true);

        T Get(params object[] primary_key);
        List<T> GetAll();

    }

    public interface IDatabaseService
    {
        int SaveChanges();
        void UndoDatabaseChanges();
        void UndoEntityChanges(object entity_to_undo);
    }

    public class BasicModelServiceImplementation<T> : IBasicModelService<T> where T : DataRowProperty
    {
        protected ApplicationDbContext _context;
        
        public BasicModelServiceImplementation(ApplicationDbContext ctx)
        {
            _context = ctx;
        }
        public T Activate(T activate, bool save_after_execute = true)
        {
            activate.IsActive = true;
            activate.DateInactivatedUtc = null;
            activate.DateLastModifiedUtc = DateTime.UtcNow;
            return Update(activate, save_after_execute);
        }

        public void Activate(List<T> activates, bool save_after_execute = true)
        {
            activates.ForEach(e => e.IsActive = true);
            Update(activates, save_after_execute);
        }

        public T Add(T add, bool save_after_execute = true)
        {
            add.IsActive = true;
            add.IsDeleted = false;
            add.DateCreatedUtc = DateTime.UtcNow;
            add.DateLastModifiedUtc = DateTime.UtcNow;

            var ent = _context.Add(add);
            if (save_after_execute) _context.SaveChanges();
            return ent.Entity;
        }

        public void Add(List<T> adds, bool save_after_execute = true)
        {
            _context.ChangeTracker.AutoDetectChangesEnabled = false;
            foreach (var ent in adds)
            {
                Add(ent, false);
            }
            if (save_after_execute) _context.SaveChanges();
            _context.ChangeTracker.AutoDetectChangesEnabled = true;
        }

        public T Deactivate(T deactivate, bool save_after_execute = true)
        {
            deactivate.IsActive = false;
            deactivate.DateInactivatedUtc = DateTime.UtcNow;
            deactivate.DateLastModifiedUtc = DateTime.UtcNow;
            return Update(deactivate, save_after_execute);
        }

        public void Deactivate(List<T> deactivates, bool save_after_execute = true)
        {
            deactivates.ForEach(e => e.IsActive = false);
            Update(deactivates, save_after_execute);
        }

        public T FlagForDelete(T delete, bool save_after_execute = true)
        {
            delete.IsDeleted = true;
            delete.DateFlaggedForDeletionUtc = DateTime.UtcNow;
            delete.DateLastModifiedUtc = DateTime.UtcNow;
            return Update(delete, save_after_execute);
        }

        public void FlagForDelete(List<T> deletes, bool save_after_execute = true)
        {
            deletes.ForEach(e => e.IsDeleted = true);
            Update(deletes, save_after_execute);
        }

        public T Get(params object[] primary_key)
        {
            return _context.Find<T>(primary_key);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T Update(T update, bool save_after_execute = true)
        {
            var ent = _context.Update(update);
            if (save_after_execute) _context.SaveChanges();
            return ent.Entity;
        }

        public void Update(List<T> updates, bool save_after_execute = true)
        {
            _context.ChangeTracker.AutoDetectChangesEnabled = false;
            foreach(var ent in updates)
            {
                Update(ent,false);
            }
            if (save_after_execute) _context.SaveChanges();
            _context.ChangeTracker.AutoDetectChangesEnabled = true;
        }
    }

}
