﻿using AN.Api.DTO.Request;
using AN.Api.Model;
using System;
using System.Collections.Generic;

namespace AN.Api.Services.Interfaces
{
    public interface IBoardService : IService<Board>
    {
        IEnumerable<Board> Get(Guid? id);
        Board GetBoardById(Guid id);
    }
}
