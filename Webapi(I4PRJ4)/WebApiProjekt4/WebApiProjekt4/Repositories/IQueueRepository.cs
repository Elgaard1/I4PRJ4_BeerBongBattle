﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProjekt4.Data.EFCore;
using WebApiProjekt4.Data;
using WebApiProjekt4.Data.Dto;

namespace WebApiProjekt4.Repositories
{
    public interface IQueueRepository : IRepository<Queue>
    {
        Task<Queue> AddUser(int userid);
        Task<GetFirstPlayerResult> GetUser();
        Task<Queue> RemovePlayer(int id);
    }
}
