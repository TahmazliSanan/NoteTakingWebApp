using Microsoft.AspNetCore.Mvc;
using NoteTakingWebApp.DTO.Dtos;
using NoteTakingWebApp.Service.Services.Abstracts;

namespace NoteTakingWebApp.UI.Controllers
{
    public class NoteController : Controller
    {
        private readonly INoteService _noteService;

        public NoteController(INoteService noteService)
        {
            _noteService = noteService;
        }

        [HttpGet]
        public IActionResult CreateNote()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateNote(NoteDto noteDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _noteService.Create(noteDto);
                    return View();
                }
                return View(noteDto);
            }
            catch (Exception exception)
            {
                return View(exception.Message);
            }
        }

        [HttpGet]
        public IActionResult GetNoteById(int id)
        {
            var note = _noteService.GetById(id);
            return View(note);
        }

        [HttpGet]
        public IActionResult GetAllNotes()
        {
            var notes = _noteService.GetAll();
            return View(notes);
        }

        [HttpGet]
        public IActionResult UpdateNote(int id)
        {
            var note = _noteService.GetById(id);
            return View(note);
        }

        [HttpPost]
        public IActionResult UpdateNote(NoteDto noteDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var updatedNote = _noteService.Update(noteDto);
                    return View("UpdateNote", updatedNote);
                }
                else
                {
                    return View(noteDto);
                }
            }
            catch (Exception exception)
            {
                return View(exception.Message);
            }
        }

        [HttpGet]
        public IActionResult DeleteNote(int id)
        {
            var note = _noteService.GetById(id);
            return View(note);
        }

        [HttpPost]
        public IActionResult DeleteNoteDto(int id)
        {
            try
            {
                _noteService.Delete(id);
                return RedirectToAction("GetAllNotes");
            }
            catch (Exception exception)
            {
                return View(exception.Message);
            }
        }
    }
}