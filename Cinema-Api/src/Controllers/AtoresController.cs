using Cinema_Api.src.Models;
using Cinema_Api.src.Models.DTOs;
using Cinema_Api.src.Service;
using Microsoft.AspNetCore.Mvc;

namespace Cinema_Api.src.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class AtoresController(AtoresService service) : ControllerBase