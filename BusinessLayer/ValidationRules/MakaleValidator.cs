using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MakaleValidator : AbstractValidator<Makale>
    {
        public MakaleValidator()
        {
            RuleFor(x => x.MakaleBaslik).NotEmpty().WithMessage("Makale Adı Boş Geçilemez");
            RuleFor(x => x.MakaleAciklama).NotEmpty().WithMessage("Makale Adı Boş Geçilemez");
            RuleFor(x => x.MakaleAciklama).MinimumLength(50).WithMessage("Makale Açıklama 50 karakterden az olamaz");
            RuleFor(x => x.MakaleAciklama).MaximumLength(500).WithMessage("Makale Açıklama 500 karakterden fazla olamaz");
            RuleFor(x => x.MakaleImgUrl).NotEmpty().WithMessage("Blog eklemek için Resim yüklemelisin");
        }
    }
}
