using Abp.Application.Services.Dto;
using Taskever.Domain.Enums;

namespace Taskever.Application.Services.Dto.Tasks
{
    public class UpdateTaskInput : IInputDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int AssignedUserId { get; set; }

        public byte Priority { get; set; }

        public byte State { get; set; }

        public byte Privacy { get; set; }
    }
}