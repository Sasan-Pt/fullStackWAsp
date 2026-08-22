using fullStackWAsp.Dtos.Media;
using fullStackWAsp.enums;
using Microsoft.AspNetCore.Mvc;

namespace fullStackWAsp.endPoints
{
    public static class EndPoints
    {
        public static void MapMediasEndpoints(this WebApplication app)
        {
            RouteGroupBuilder rootApi = app.MapGroup("/api/media/").WithTags("media");
            rootApi.MapGet("/all", (AppDbContext context) => {

                var courses = context.Medias;
                return TypedResults.Ok(courses);
            });

            rootApi.MapPost("/create", (AppDbContext context, [FromBody] CreateMediaDto dto) => {
                var media = new MediaEntity
                {
                    MediaType = dto.MediaType,
                    ReleaseDate = dto.ReleaseDate,
                    Code = dto.Code,
                    Title = dto.Title,
                    EnTitle = dto.EnTitle,
                    Slug = dto.Slug,
                    SubTitle = dto.SubTitle,
                    Duration = dto.Duration,
                    Description = dto.Description,
                    IntroVideoUrl = dto.IntroVideoUrl,
                    BannerUrl = dto.BannerUrl,
                    Status = dto.Status,

                };
                context.Medias.Add(media);
         
                context.SaveChanges();
                return Results.Created($"/media/{media.Id}", media);


            });

            rootApi.MapPost("/update/{id}", (AppDbContext context, [FromBody] EditMediaDto dto,int id) => {
                var selectedMedia = context.Medias.Where(p => p.Id == id).FirstOrDefault();
                if (selectedMedia is not null)
                {
                    selectedMedia.MediaType = dto.MediaType;
                    selectedMedia.ReleaseDate = dto.ReleaseDate;
                    selectedMedia.Title = dto.Title;
                    selectedMedia.EnTitle = dto.EnTitle;
                    selectedMedia.SubTitle = dto.SubTitle;
                    selectedMedia.Duration = dto.Duration;
                    selectedMedia.Description = dto.Description;
                    selectedMedia.IntroVideoUrl = dto.IntroVideoUrl;
                    selectedMedia.BannerUrl = dto.BannerUrl;
                    selectedMedia.Status = dto.Status;

                }
                else
                {
                    throw new BadHttpRequestException("not found");

                }
                ;

                context.SaveChanges();
                return Results.Created($"/media/{selectedMedia.Id}", selectedMedia);


            });

            rootApi.MapGet("/{id}", (AppDbContext context, int id) => {
                var media = context.Medias.Find(id);
                return TypedResults.Ok(media);
            });
        } }
}
