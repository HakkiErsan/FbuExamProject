using ExamDal.Entities;
using ExamDal.Repositories;
using FbuExamMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FbuExamMVC.Controllers
{
    public class ExamController : Controller
    {
        private ExamRepository _examRepository;
        public ExamController(ExamRepository examRepository)
        {
            _examRepository = examRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListExam()
        {
            List<ExamDefinitionViewModel> model = new List<ExamDefinitionViewModel>();

            List<ExamDefinition> liste = _examRepository.GetExams();
            foreach (var exam in liste)
            {
                model.Add(new ExamDefinitionViewModel() { Id = exam.Id, Name = exam.Name });
            }
            
            return View(model);
        }

        public IActionResult AddExam()
        {
            ExamDefinitionViewModel model = new ExamDefinitionViewModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult AddExam(ExamDefinitionViewModel model)
        {
            ExamDefinition dataModel = new ExamDefinition();
            dataModel.Name = model.Name;
            _examRepository.Insert(dataModel);
            return RedirectToAction("ListExam");
        }
    }
}

