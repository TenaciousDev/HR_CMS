using HR_CMS.Data;
using HR_CMS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_CMS.Services
{
    public class PositionService
    {
        public bool CreatePosition(PositionCreate model)
        {
            var entity = new Position()
            {
                PositionTitle = model.PositionTitle,
                DeptId = model.DeptId,
                IsSupervisor = model.IsSupervisor,
                IsDirector = model.IsDirector,
                IsExecutive = model.IsExecutive
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.PositionDbSet.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<PositionListItem> GetPositions()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx
                    .PositionDbSet
                    .Select(
                        e =>
                            new PositionListItem
                            {
                                PositionId = e.PositionId,
                                PositionTitle = e.PositionTitle,
                                DeptId = e.DeptId,
                                IsSupervisor = e.IsSupervisor,
                                IsDirector = e.IsDirector,
                                IsExecutive = e.IsExecutive
                            }
                    );
                return query.ToArray();
            }
        }
        public IEnumerable<PositionListItem> GetPositionsByDept(int deptId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx
                    .PositionDbSet
                    .Where(e => e.DeptId == deptId)
                    .Select(
                        e =>
                            new PositionListItem
                            {
                                PositionId = e.PositionId,
                                PositionTitle = e.PositionTitle,
                                DeptId = e.DeptId,
                                IsSupervisor = e.IsSupervisor,
                                IsDirector = e.IsDirector,
                                IsExecutive = e.IsExecutive
                            }
                    );
                return query.ToArray();
            }
        }
        public PositionDetail GetPositionById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .PositionDbSet
                        .Single(e => e.PositionId == id);
                return
                    new PositionDetail
                    {
                        PositionId = entity.PositionId,
                        PositionTitle = entity.PositionTitle,
                        DeptId = entity.DeptId,
                        IsSupervisor = entity.IsSupervisor,
                        IsDirector = entity.IsDirector,
                        IsExecutive = entity.IsExecutive,
                    };
            }
        }
        public bool UpdatePosition(PositionDetail model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .PositionDbSet
                    .Single(e => e.PositionId == model.PositionId);
                entity.PositionTitle = model.PositionTitle;
                entity.DeptId = model.DeptId;
                entity.IsSupervisor = model.IsSupervisor;
                entity.IsDirector = model.IsDirector;
                entity.IsExecutive = model.IsExecutive;
                return ctx.SaveChanges() == 1;
            }
        }

    }
}
