using FluentValidation;
using VinylStore.Catalog.Domain.Commands.Artist;

namespace VinylStore.Catalog.Domain.Commands.Artists.Validators
{
    public class AddArtistCommandValidator : AbstractValidator<AddArtistCommand>
    {
        public AddArtistCommandValidator()
        {
            RuleFor(artist => artist.ArtistName).NotEmpty();
        }
    }
}