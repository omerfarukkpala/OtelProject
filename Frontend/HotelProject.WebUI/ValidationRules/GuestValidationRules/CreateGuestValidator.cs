using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.ValidationRules.GuestValidationRules
{
    public class CreateGuestValidator : AbstractValidator<CreateGuestDto>
    {
        public CreateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı için boş geçilemez"); 
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim  alanı için boş geçilemez"); 
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir alanı için boş geçilemez"); 

            RuleFor(x => x.Name).MinimumLength(3).WithMessage("İsim alanı için en az  3 karakter olmalıdır"); 
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Soyisim alanı için en az 2 karakter olmalıdır"); 
            RuleFor(x => x.City).MinimumLength(3).WithMessage("Şehir alanı için en az 3 karakter olmalıdır");

            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter için veri girişi yapınız");
            RuleFor(x => x.Surname).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter için veri girişi yapınız");
            RuleFor(x => x.City).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter veri  için girişi yapınız");

            
        }
    }
}
