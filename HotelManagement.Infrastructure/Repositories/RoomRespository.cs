﻿using HotelManagement.Core.Domains;
using HotelManagement.Core.IRepositories;
using HotelManagement.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Infrastructure.Repositories
{
    public class RoomRespository: GenericRepository<Room>,IRoomRepository
    {
        public RoomRespository(HotelDbContext hotelDbContext):base(hotelDbContext)
        {

        }

        public void Add(string Hotel_ID, Room room)
        {
            throw new NotImplementedException();
        }
    }
}
