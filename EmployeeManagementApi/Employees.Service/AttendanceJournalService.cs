using Employees.Core.Entites;
using Employees.Core.Repositories;
using Employees.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Service
{
    /*
     * A = there is an error in the details
     * */
    public enum ErrorsMassage {A, B }
    public class AttendanceJournalService : IAttendanceJournalService
    {
        private readonly IAttendanceJournalRepository _repository;
        public AttendanceJournalService(IAttendanceJournalRepository repositoy)
        {
            _repository = repositoy;
        }


        public Task<IEnumerable<AttendanceJournal>> GetAllAttendanceJournalByEmployeeIdAsync(int employeeId)
        {
            return _repository.GetAllAttendanceJournalByEmployeeIdAsync(employeeId);
        }

        public Task<AttendanceJournal> AddAsync(int employeeId, AttendanceJournal attendanceJournal)
        {
            if (employeeId > 0)
                return _repository.AddAsync(employeeId, attendanceJournal);
            else
                throw new Exception(ErrorsMassage.A.ToString());
        }

    }
}
