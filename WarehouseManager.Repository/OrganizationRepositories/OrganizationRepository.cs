using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Data;
using WarehouseManager.Data.BaseEntities;
using WarehouseManager.Data.Entities;

namespace WarehouseManager.Repository.BaseRepositories
{
    public class OrganizationRepository : Repository<Organization>, IOrganizationRepository
    {
        public OrganizationRepository(WarehouseManagerDBContext orgContext) : base(orgContext) { }

        public Organization GetByAddress(string addressToFind)
        {
            return _context.Set<Organization>().FirstOrDefault(x => x.Address == addressToFind);
        }

        public Organization GetByAuthenticationCode(string authenticationCodeToFind)
        {
            return _context.Set<Organization>().FirstOrDefault(x => x.AuthenticationCode == authenticationCodeToFind);
        }

        public Organization GetByCity(string cityToFind)
        {
            return _context.Set<Organization>().FirstOrDefault(x => x.City == cityToFind);
        }

        public Organization GetByCode(string codeToFind)
        {
            return _context.Set<Organization>().FirstOrDefault(x => x.Code == codeToFind);
        }

        public Organization GetByDistrict(string districtToFind)
        {
            return _context.Set<Organization>().FirstOrDefault(x => x.District == districtToFind);
        }

        public Organization GetByEmail(string emailToFind)
        {
            return _context.Set<Organization>().FirstOrDefault(x => x.Email == emailToFind);
        }

        public Organization GetByEN_Name(string enNameToFind)
        {
            return _context.Set<Organization>().FirstOrDefault(x => x.EN_Name == enNameToFind);
        }

        public Organization GetByLongitudeAndLatitude(double longitudeToFind, double latitudeToFind)
        {
            return _context.Set<Organization>().FirstOrDefault(x => x.Longitude == longitudeToFind && x.Latitude == latitudeToFind);
        }

        public Organization GetByName(string nameToFind)
        {
            return _context.Set<Organization>().FirstOrDefault(x => x.Name == nameToFind);
        }

        public Organization GetByOrgType(OrganizationType orgTypeToFind)
        {
            return _context.Set<Organization>().FirstOrDefault(x => x.OrgType == orgTypeToFind);
        }

        public Organization GetByPhoneNumber(string phoneNumberToFind)
        {
            return _context.Set<Organization>().FirstOrDefault(x => x.PhoneNumber == phoneNumberToFind);
        }

        public Organization GetByPostalCode(string postalCodeToFind)
        {
            return _context.Set<Organization>().FirstOrDefault(x => x.PostalCode == postalCodeToFind);
        }

        public Organization GetByWebsiteURL(string websiteURLToFind)
        {
            return _context.Set<Organization>().FirstOrDefault(x => x.WebsiteURL == websiteURLToFind);
        }
    }
}
