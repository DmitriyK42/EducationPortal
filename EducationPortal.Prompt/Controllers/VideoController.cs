﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationPortal.BLL.DTO;
using EducationPortal.BLL.Interfaces;
using EducationPortal.DAL.Interfaces;
using EducationPortal.Prompt.Models;
using Microsoft.Extensions.DependencyInjection;

namespace EducationPortal.Prompt.Controllers
{
    public class VideoController
    {
        private IVideoService VideoService => AppContext.ServiceProvider.GetRequiredService<IVideoService>();

        VideoModel GetVideo(Guid id)
        {
            VideoDTO video = this.VideoService.GetVideo(id);
            
            if (video == null)
            {
                return null;
            }

            return new VideoModel
            {
                Id = video.Id,
                Name = video.Name,
                Owner = video.Owner,
                Duration = video.Duration,
                Link = video.Duration,
                Quality = video.Quality
            };
        }

        public void AddVideo(VideoModel model)
        {
            VideoDTO newVideo = new VideoDTO
            {
                Id = model.Id,
                Name = model.Name,
                Owner = model.Owner,
                Duration = model.Duration,
                Link = model.Link,
                Quality = model.Quality
            };

            this.VideoService.AddVideo(newVideo);
        }



    }
}
