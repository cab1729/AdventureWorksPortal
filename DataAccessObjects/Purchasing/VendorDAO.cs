using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Objects;
using System.Data.Entity;

namespace AdventureWorks.Domain.DataAccessObjects.Purchasing
{
    using AdventureWorks.Domain.DataAccessObjects;
    using AdventureWorks.Domain.ModelObjects.Entities;

    public interface IVendorDAO
    {
        IEnumerable<Vendor> getVendors();
        Vendor getVendorDetails(int id);
        void addVendor(Vendor vendor);
        void editVendor(Vendor vendor);
        void deleteVendor(int id);

        IEnumerable<BusinessEntity> getBusinessEntities();
        vVendorWithAddress getVendorAddress(int id);
        vVendorWithContact getVendorContact(int id);

    }
    public class VendorDAO : IVendorDAO
    {
        private AdventureWorksModelContainer _db = new AdventureWorksModelContainer();
        
        public IEnumerable<Vendor> getVendors()
        {
            var vendors = _db.Vendors.Include("BusinessEntity");
            return vendors.ToList();
        }

        public Vendor getVendorDetails(int id)
        {
            Vendor vendor = _db.Vendors.Single(v => v.BusinessEntityID == id);
            return vendor;
        }

        public void addVendor(Vendor vendor)
        {
            _db.Vendors.Add(vendor).ModifiedDate = System.DateTime.Now;
            _db.SaveChanges();
        }

        public void editVendor(Vendor vendor)
        {
            _db.Vendors.Attach(vendor).ModifiedDate = System.DateTime.Now;
            _db.Entry(vendor).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void deleteVendor(int id)
        {
            Vendor vendor = _db.Vendors.Single(v => v.BusinessEntityID == id);
            _db.Entry(vendor).State = EntityState.Deleted;
            _db.Vendors.Remove(vendor);
            _db.SaveChanges();
        }

        public IEnumerable<BusinessEntity> getBusinessEntities()
        {
            return _db.BusinessEntities.AsEnumerable<BusinessEntity>();
        }

        public vVendorWithAddress getVendorAddress(int id)
        {
            return _db.vVendorWithAddresses.FirstOrDefault(v => v.BusinessEntityID == id);
        }

        public vVendorWithContact getVendorContact(int id)
        {
            return _db.vVendorWithContacts.FirstOrDefault(v => v.BusinessEntityID == id);
        }
    }
}
