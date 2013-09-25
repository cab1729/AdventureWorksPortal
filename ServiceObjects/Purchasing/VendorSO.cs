using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureWorks.Domain.ServiceObjects.Purchasing
{
    using AdventureWorks.Domain.DataAccessObjects;
    using AdventureWorks.Domain.DataAccessObjects.Purchasing;
    using AdventureWorks.Domain.ModelObjects.Entities;

    public interface IVendorSO
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

    public class VendorSO : IVendorSO
    {
        private IVendorDAO _VendorDAO = DAOFactory.Instance.VendorDAO;

        public IEnumerable<Vendor> getVendors()
        {
            return _VendorDAO.getVendors();
        }

        public Vendor getVendorDetails(int id)
        {
            return _VendorDAO.getVendorDetails(id);
        }

        public void addVendor(Vendor vendor)
        {
            _VendorDAO.addVendor(vendor);
        }

        public void editVendor(Vendor vendor)
        {
            _VendorDAO.editVendor(vendor);
        }

        public void deleteVendor(int id)
        {
            _VendorDAO.deleteVendor(id);
        }

        public IEnumerable<BusinessEntity> getBusinessEntities()
        {
            return _VendorDAO.getBusinessEntities();
        }

        public vVendorWithAddress getVendorAddress(int id)
        {
            return _VendorDAO.getVendorAddress(id);
        }

        public vVendorWithContact getVendorContact(int id)
        {
            return _VendorDAO.getVendorContact(id);
        }
    }
}
