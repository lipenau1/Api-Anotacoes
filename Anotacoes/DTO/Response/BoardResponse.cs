﻿using AN.Api.Model;
using System;
using System.Collections.Generic;

namespace AN.Api.DTO.Response
{
    public class BoardResponse
    {
        public BoardResponse()
        {
            Containers = new List<ContainerResponse>();
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public int UserId { get; set; }
        public IEnumerable<ContainerResponse> Containers { get; set; }
    }
}
