using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YcTeam.IBLL.Master
{
    public interface IProjectService
    {
        Task CreateProject(string name, string wBSCode, string smallaProject, string smallWBSCode, string nitialApprovalFunds, string voltageGrade, string projectDepartment, string pickingPeople, string contactNumber);

        Task EditProject(Guid projectId, string name, string wBSCode, string smallaProject, string smallWBSCode, string nitialApprovalFunds, string voltageGrade, string projectDepartment, string pickingPeople, string contactNumber);

        Task RemoveProject(Guid id);

        Task<List<DTO.Master.ProjectDto>> GetAllProject(int pageSize, int pageIndex, bool asc);

        Task<int> GetDataCount();
        Task<bool> ExistsProject(Guid projectId);
    }
}
