using CtlWebApp.Contract;
using CtlWebApp.Core.ICityRepository;
using CtlWebApp.Core.IPeapleRepository;
using CtlWebApp.Core.IStateRepositorys;
using CtlWebApp.Core.People;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WebApplicationEMPM.Models;

namespace WebApplicationEMPM.Controllers
{
    public class PeopleController : Controller
    {
        private readonly ICityRepository cityRepository;
        private readonly IEducatioRepository educatioRepository;
        private readonly IPersonRepository personRepository;
        private readonly IStateRepository stateRepository;
        private readonly IWorkHistoryRepository workHistoryRepository;
        public PeopleController(ICityRepository cityRepository, IEducatioRepository educatioRepository, IPersonRepository personRepository, IStateRepository stateRepository, IWorkHistoryRepository workHistoryRepository)
        {
            this.workHistoryRepository = workHistoryRepository;
            this.cityRepository = cityRepository;
            this.personRepository = personRepository;
            this.educatioRepository = educatioRepository;
            this.stateRepository = stateRepository;
        }
        public IActionResult Delete(int id = 0)
        {
            Person person = personRepository.Get(id);
            return View(person);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult Deletepost(int id = 0)
        {

            personRepository.Delete(id);
            return RedirectToAction("List");
        }
        public IActionResult List()
        {
            var People = personRepository.GetAll().ToList();
            return View(People);
        }
        public IActionResult Edit(int id)
        {
            var wor = workHistoryRepository.GetPersonworkhistory(id);
            var edu = educatioRepository.GetPersonEducations(id);
            var ditail = personRepository.Get(id);
            ditail.educationsHistory = edu.ToList();
            ditail.workHistories = wor.ToList();
            return View(ditail);
        }
        public IActionResult Index()
        {
            return View();
        }
        public class EnumModel
        {
            public int Value { get; set; }
            public string Name { get; set; }
        }
        public IActionResult AddressInfo(int id)
        {
            var cities = cityRepository.GetAll().ToList();
            ViewBag.City = cities;
            var states = stateRepository.GetAll().ToList();
            ViewBag.State = states;
            return View(new AddNewAddressInfoModel() { Id = id });
        }
        [HttpPost]
        public IActionResult AddressInfo(AddNewAddressInfoModel model)
        {
            var person = personRepository.Get(model.Id);
            if (ModelState.IsValid)
            {

                person.Number = model.Number;
                person.Street = model.Street;
                person.Avenue = model.Avenue;

                person.Address = model.Address;
                    
               
            personRepository.Edit(person);
                return RedirectToAction("Education",new { id = person.Id });
            }
            return View();
        }
        public IActionResult Education(int id)
        {

            return View(new AddNewEducationModel() { Id = id });
        }
        [HttpPost]
        public IActionResult Education(AddNewEducationModel model)
        {
            var person = personRepository.Get(model.Id);
            if (ModelState.IsValid)
            {
              var ed=  new Education()
                {
                    city = model.city,
                    DateReceived = model.DateReceived,
                    FeildOfStudy = model.FeildOfStudy,
                    Orientaion = model.Orientaion,
                    TotalAverage = model.TotalAverage
                };
                person.educationsHistory.Add(ed);



                personRepository.Edit(person);

                return RedirectToAction("MilitaryServiceStatus",new {id= person.Id});
            }
            return View();
        }
        public IActionResult MilitaryServiceStatus(int id)
        {


            return View(new AddNewMilitaryServiceStatusModel() { Id = id });
        }
        [HttpPost]
        public IActionResult MilitaryServiceStatus(AddNewMilitaryServiceStatusModel model)
        {
            var person = personRepository.Get(model.Id);
            if (ModelState.IsValid)
            {

                person.IdentityNumber = model.IdentityNumber;
                person.DateOfDispatch = model.DateOfDispatch;
                person.Releasedate = model.Releasedate;
                person.VazifeState = model.varzifaState;
               
                personRepository.Edit(person);
                return RedirectToAction("Resume",new { id= person.Id });
            }
            return View();
        }
        public IActionResult Resume(int id)
        {

            return View(new AddNewResumeModel() { Id = id });
        }
        [HttpPost]
        public IActionResult Resume(AddNewResumeModel model)
        {
            var person = personRepository.Get(model.Id);
            if (ModelState.IsValid)
            {


                person.VerficationCode = model.VerficationCode;
                person.Acceptenc = model.Acceptenc;
                person.Skill = model.Skill;
              
                var workHistory = new WorkHistory
                {

                    WorkPlaceName = model.WorkPlaceName,
                    EndDate = model.EndDate,
                    Jobtittle = model.Jobtittle,
                    LastRight = model.LastRight,
                    ReasonForLeavingServeices = model.ReasonForLeavingServeices
                };
                personRepository.Edit(person);
                person.workHistories.Add(workHistory);
                return RedirectToAction("List");
            }

            return View("List", "People");
        }
        public IActionResult EMPM()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EMPM(AddNewPersonViewModel model)
        {
            if (ModelState.IsValid)
            {
                Person person = new Person
                {
                    NationalCode = model.NationalCode,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    BirthDate = model.BirthDate,
                    BirthPlace = model.BirthPlace,
                    PhoneNumber = model.PhoneNumber,
                    
                    NameOfFather = model.NameOfFather,
                    Address="",
                    Gender = model.gender,
                    MartialStatus = model.Martial
                };
                if (model.Image.Length > 0)
                {
                    using (var ms = new MemoryStream())
                    {
                        model.Image.CopyTo(ms);
                        var fileBytes = ms.ToArray();
                        person.Image = fileBytes;
                        //  string s = Convert.ToBase64String(fileBytes);
                        // act on the Base64 data
                    }
                    personRepository.Add(person);
                }
               // var person2 = personRepository.GetByNationalCode(model.NationalCode);
                return RedirectToAction("AddressInfo", new { id = person.Id });
            }
            throw new Exception("خطا امیر");
            // return View();
        }
        public IActionResult Update(int id, AddNewPersonViewModel model, AddNewAddressInfoModel addNewAddressInfoModel,
            AddNewEducationModel addNewEducationModel,
            AddNewMilitaryServiceStatusModel addNewMilitaryServiceStatusModel, AddNewResumeModel addNewResumeModel)
        {
            var eidt = personRepository.Get(id);
            Person person = new Person();
            new AddNewPersonViewModel
            {
                NationalCode = model.NationalCode,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                BirthDate = model.BirthDate,
                BirthPlace = model.BirthPlace,
                PhoneNumber = model.PhoneNumber,
                NameOfFather = model.NameOfFather,
                gender = model.gender,
                Martial = model.Martial
            };
            new AddNewAddressInfoModel
            {

                Address = addNewAddressInfoModel.Address,
                Avenue = addNewAddressInfoModel.Avenue,
                Street = addNewAddressInfoModel.Street,
                Number = addNewAddressInfoModel.Number
            };
            new AddNewEducationModel
            {
                city = addNewEducationModel.city,
                DateReceived = addNewEducationModel.DateReceived,
                FeildOfStudy = addNewEducationModel.FeildOfStudy,
                Orientaion = addNewEducationModel.Orientaion,
                TotalAverage = addNewEducationModel.TotalAverage
            };
            new AddNewMilitaryServiceStatusModel
            {
                IdentityNumber = addNewMilitaryServiceStatusModel.IdentityNumber,
                varzifaState = addNewMilitaryServiceStatusModel.varzifaState,
                DateOfDispatch = addNewMilitaryServiceStatusModel.DateOfDispatch,
                Releasedate = addNewMilitaryServiceStatusModel.Releasedate
            };
            new AddNewResumeModel
            {

                Acceptenc = addNewResumeModel.Acceptenc,
                Skill = addNewResumeModel.Skill,
                VerficationCode = addNewResumeModel.VerficationCode,
                EndDate = addNewResumeModel.EndDate,
                Jobtittle = addNewResumeModel.Jobtittle,
                LastRight = addNewResumeModel.LastRight,
                ReasonForLeavingServeices = addNewResumeModel.ReasonForLeavingServeices
            };
            if (model.Image.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    model.Image.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    person.Image = fileBytes;
                    //  string s = Convert.ToBase64String(fileBytes);
                    // act on the Base64 data
                }
            }


            var cities = cityRepository.GetAll().ToList();
            ViewBag.City = cities;
            var states = stateRepository.GetAll().ToList();
            ViewBag.State = states;

            return View(model);
        }
        [HttpPost]
        public IActionResult Update(AddNewPersonViewModel model, int id, AddNewAddressInfoModel addNewAddressInfoModel,
            AddNewEducationModel addNewEducationModel,
            AddNewMilitaryServiceStatusModel addNewMilitaryServiceStatusModel, AddNewResumeModel addNewResumeModel)
        {
            if (ModelState.IsValid)
            {
                Person person = personRepository.Get(id);
                person = new Person
                {
                    NationalCode = model.NationalCode,
                    IdentityNumber = addNewMilitaryServiceStatusModel.IdentityNumber,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    BirthDate = model.BirthDate,
                    BirthPlace = model.BirthPlace,
                    PhoneNumber = model.PhoneNumber,
                    NameOfFather = model.NameOfFather,
                    DateOfDispatch = addNewMilitaryServiceStatusModel.DateOfDispatch,
                    Releasedate = addNewMilitaryServiceStatusModel.Releasedate,
                    Acceptenc = addNewResumeModel.Acceptenc,
                    Skill = addNewResumeModel.Skill,
                    VerficationCode = addNewResumeModel.VerficationCode,
                    Address = addNewAddressInfoModel.Address,
                    Avenue = addNewAddressInfoModel.Avenue,
                    Street = addNewAddressInfoModel.Street,
                    Number = addNewAddressInfoModel.Number,
                    Gender = model.gender,
                    MartialStatus = model.Martial,
                    VazifeState = addNewMilitaryServiceStatusModel.varzifaState
                };
                if (model.Image.Length > 0)
                {
                    using (var ms = new MemoryStream())
                    {
                        model.Image.CopyTo(ms);
                        var fileBytes = ms.ToArray();
                        person.Image = fileBytes;
                        //  string s = Convert.ToBase64String(fileBytes);
                        // act on the Base64 data
                    }
                }
                Education education = new Education
                {
                    city = addNewEducationModel.city,
                    DateReceived = addNewEducationModel.DateReceived,
                    FeildOfStudy = addNewEducationModel.FeildOfStudy,
                    Orientaion = addNewEducationModel.Orientaion,
                    TotalAverage = addNewEducationModel.TotalAverage
                };
                WorkHistory workHistory = new WorkHistory
                {
                    EndDate = addNewResumeModel.EndDate,
                    Jobtittle = addNewResumeModel.Jobtittle,
                    LastRight = addNewResumeModel.LastRight,
                    ReasonForLeavingServeices = addNewResumeModel.ReasonForLeavingServeices
                };
                personRepository.Edit(person);
                educatioRepository.Edit(education);
                workHistoryRepository.Edit(workHistory);
                return RedirectToAction("EMPM", "Update");
            }
            return View("List");
        }
    }
}
