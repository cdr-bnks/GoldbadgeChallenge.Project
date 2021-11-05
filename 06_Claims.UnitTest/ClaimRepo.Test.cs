using _05_Claims.Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_Claims.UnitTest
{
    [TestClass]
    public class UnitTest1
   {
        private ClaimRepo _claimRepo;
        private Claim _data;

        [TestInitialize]
        public void Arrange()
        {
            _claimRepo = new ClaimRepo();

            _data = new Claim(1, ClaimType.Medical, "fell down the stairs", 120.00, DateTime.Parse("11/5/2021"), DateTime.Parse("12/30/2021"));

            _claimRepo.AddClaimToList(_data);
        }
        [TestMethod]
        public void AddCLaimToList__ShouldgetNotNull()
        {
            Claim claim = new Claim();
            claim.ClaimID = 1;
            
            ClaimRepo dataRepo = new ClaimRepo();
            dataRepo.AddClaimToList(claim);

            Claim claimFromDirectory = dataRepo.GetClaimByID(1);

            Assert.IsNotNull(claimFromDirectory);
        }
    }
    
}
