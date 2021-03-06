﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RMS.App.ViewModels.ValidationModels;
using RMS.Models.EntityModels;

namespace RMS.App.ViewModels
{
    public class ReAssignRequisitionViewModel
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Please Enter valid Vehicle Information")]
        [Display(Name = "Vehicle Reg No")]
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }

        [Required(ErrorMessage = "Please Enter valid Driver Information")]
        [Display(Name = "Driver")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [Display(Name = "Requisition Status")]
        public int RequisitionStatusId { get; set; }
        public RequisitionStatus RequisitionStatus { get; set; }
        
        public List<VehicleType> VehicleTypes { get; set; }
        
        
        public AssignRequisitionViewModel AssignRequisitionViewModel { get; set; }
        
        [Required(ErrorMessage = "Please provide a journey start date and time!")]
        [Display(Name = "Journey Date")]
        public DateTime StartDateTime { get; set; }
        
        
        [Required(ErrorMessage = "Please provide a journey end date and time!")]
        [Display(Name = "Return Date")]
        public DateTime EndDateTime { get; set; }



    }
}