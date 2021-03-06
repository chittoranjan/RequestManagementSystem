﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.App.ViewModels.Report;
using RMS.BLL.Base;
using RMS.BLL.Contracts;
using RMS.Models.EntityModels;
using RMS.Models.EntityViewModel;
using RMS.Models.Report;
using RMS.Repositories.Contracts;

namespace RMS.BLL
{
    public class AssignRequisitionManager:Manager<AssignRequisition>,IAssignRequisitionManager
    {
        private IAssignRequisitionRepository _assignRequisitionRepository;
        public AssignRequisitionManager(IAssignRequisitionRepository repository) : base(repository)
        {
            this._assignRequisitionRepository = repository;
        }

        public ICollection<AssignRequisition> GetAllWithInformation()
        {
            return _assignRequisitionRepository.GetAllWithInformation();
        }

        public AssignRequisition SearchByName(string searchByText)
        {
            return _assignRequisitionRepository.SearchByText(searchByText);
        }

        public AssignRequisition GetVehicleStatus(int vehicleId)
        {
            return _assignRequisitionRepository.GetVehicleStatus(vehicleId);
        }

        public AssignRequisition GetDriverStatus(int driverId)
        {
            return _assignRequisitionRepository.GetDriverStatus(driverId);
        }

        public ICollection<AssignRequisitionReportVM> GetRequisitionSummaryReport()
        {
            return _assignRequisitionRepository.GetRequisitionSummaryReport();
        }
        public ICollection<AssignReportVm> GetAssignRequisition(int assignRequisitionId)
        {
            return _assignRequisitionRepository.GetAssignRequisition(assignRequisitionId);
        }

    }
}
