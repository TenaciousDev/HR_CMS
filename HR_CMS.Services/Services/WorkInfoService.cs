﻿using HR_CMS.Data;
using HR_CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_CMS.Services
{
    public class WorkInfoService
    {
        public bool CreateWorkInfo(WorkInfoCreate model)
        {
            var entity = new WorkInfo()
            {
                PersonnelId = model.PersonnelId,
                PositionId = model.PositionId,
                Wage = model.Wage,
                WorkEmail = model.WorkEmail,
                LastReview = model.LastReview,
                PositionHeld = model.Position,
                
               
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.WorkInfoDbSet.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public bool EditWorkInfo(WorkInfoEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.WorkInfoDbSet.Single(e => e.PersonnelId == model.PersonnelId);
                entity.WorkInfoId = model.WorkInfoId;
                entity.PositionId = model.PositionId;
                entity.Wage = model.Wage;
                entity.WorkEmail = model.WorkEmail;
                entity.LastReview = model.LastReview;

                return ctx.SaveChanges() == 1;
            }
        }

        public WorkInfoDetail GetWorkInfo(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.WorkInfoDbSet.Single(e => e.PersonnelId == id);
                return new WorkInfoDetail
                {
                    WorkInfoId = entity.WorkInfoId,
                    PositionId = entity.PositionId,
                    Wage = entity.Wage,
                    HasBenefits = entity.HasBenefits,
                    StartOfBenefits = entity.StartOfBenefits,
                    WorkEmail = entity.WorkEmail,
                    VacationDaysAccruedLifetime = entity.VacationDaysAccruedLifetime,
                    VacationDaysUsedLifetime = entity.VacationDaysUsedLifetime,
                    VacationDaysAccruedForPeriod = entity.VacationDaysAccruedForPeriod,
                    VacationDaysUsedForPeriod = entity.VacationDaysUsedForPeriod,
                    PersonalDaysAccruedLifetime = entity.PersonalDaysAccruedLifetime,
                    PersonalDaysUsedLifetime = entity.PersonalDaysUsedLifetime,
                    PersonalDaysAccruedForPeriod = entity.PersonalDaysAccruedForPeriod,
                    PersonalDaysUsedForPeriod = entity.PersonalDaysUsedForPeriod,
                    SickDaysAccruedLifetime = entity.SickDaysAccruedLifetime,
                    SickDaysUsedLifetime = entity.SickDaysUsedLifetime,
                    SickDaysAccruedForPeriod = entity.SickDaysAccruedForPeriod,
                    SickDaysUsedForPeriod = entity.SickDaysUsedForPeriod
                };
            }
        }
                public WorkInfoDetail GetDeptByPersonnelId(int id)
                {
                    using (var ctx = new ApplicationDbContext())
                    {
                        var entity = ctx.WorkInfoDbSet.Single(e => e.PersonnelId == id );
                return new WorkInfoDetail
                {
                    DeptName = entity.PositionHeld.Department.DeptName
                };
                    }
                }
        public WorkInfoDetail GetPositionByPersonnelId(int id)
        {
            {
                using (var ctx = new ApplicationDbContext())
                {
                    var entity = ctx.WorkInfoDbSet.Single(e => e.PersonnelId == id);
                    return new WorkInfoDetail
                    {
                        PositionTitle = entity.PositionHeld.PositionTitle,
                        IsSupervisor = entity.PositionHeld.IsSupervisor,
                        IsDirector = entity.PositionHeld.IsDirector,
                        IsExecutive = entity.PositionHeld.IsDirector
                    };
                }
            }
        }
        /*public WorkInfoDetail GetSupervisorByPersonnelId(int id)
        {
            {
                using (var ctx = new ApplicationDbContext())
                {
                    var entity = ctx.WorkInfoDbSet.Where(e => e.PositionHeld.DeptId != 0).Single(e => e.PersonnelId == id);
                    return new WorkInfoDetail
                    {
                        PositionTitle = entity.PositionHeld.PositionTitle,
                        
                    };
                }
            }
        }*/
       
        public IEnumerable<WorkInfoListItem> GetWorkInfo()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.WorkInfoDbSet.Select(e => new WorkInfoListItem
                {
                    WorkInfoId = e.WorkInfoId,
                    PositionId = e.PositionId,
                    Wage = e.Wage,
                    StartOfBenefits = e.StartOfBenefits,
                    WorkEmail = e.WorkEmail,
                }
                    );

                return query.ToArray();
            }

        }
        public IEnumerable<WorkInfoListItem> GetWorkInfoByActive()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.WorkInfoDbSet.Where(e => e.Personnel.IsActive == true)
                    .Select(e => new WorkInfoListItem
                {
                    WorkInfoId = e.WorkInfoId,
                    PositionId = e.PositionId,
                    Wage = e.Wage,
                    StartOfBenefits = e.StartOfBenefits,
                    WorkEmail = e.WorkEmail,
                }
                    );

                return query.ToArray();
            }

        }
        public IEnumerable<WorkInfoListItem> GetWorkInfoByInactive()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.WorkInfoDbSet.Where(e => e.Personnel.IsActive == false)
                    .Select(e => new WorkInfoListItem
                    {
                        WorkInfoId = e.WorkInfoId,
                        PositionId = e.PositionId,
                        Wage = e.Wage,
                        StartOfBenefits = e.StartOfBenefits,
                        WorkEmail = e.WorkEmail,
                    }
                    );

                return query.ToArray();
            }

        }
        public IEnumerable<WorkInfoListItem> GetPersonnelByDeptId(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.WorkInfoDbSet.Where(e => e.PositionHeld.DeptId == id)
                    .Select(e => new WorkInfoListItem
                    {
                        FirstName= e.Personnel.FirstName,
                        LastName = e.Personnel.LastName,
                        PositionTitle = e.PositionHeld.PositionTitle
                    }
                    );

                return query.ToArray();
            }

        }
    }
}
