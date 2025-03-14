﻿using Application.DTO;
using Application.Use_Cases.Queries.Image;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using MediatR;

namespace Application.Use_Cases.QueryHandlers.ImageQH
{
    public class GetImagesQueryHandler : IRequestHandler<GetImagesQuery, List<ImageDto>>
    {
        private readonly IGenericEntityRepository<Image> repository;
        private readonly IMapper mapper;

        public GetImagesQueryHandler(IGenericEntityRepository<Image> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<ImageDto>> Handle(GetImagesQuery request, CancellationToken cancellationToken)
        {
            var contacts = await repository.GetAllAsync();
            return mapper.Map<List<ImageDto>>(contacts);

        }
    }
}
