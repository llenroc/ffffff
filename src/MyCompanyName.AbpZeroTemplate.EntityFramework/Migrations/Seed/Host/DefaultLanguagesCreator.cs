﻿using System.Collections.Generic;
using System.Linq;
using Abp.Localization;
using MyCompanyName.AbpZeroTemplate.EntityFramework;

namespace MyCompanyName.AbpZeroTemplate.Migrations.Seed.Host
{
    public class DefaultLanguagesCreator
    {
        public static List<ApplicationLanguage> InitialLanguages { get; private set; }

        private readonly AbpZeroTemplateDbContext _context;

        static DefaultLanguagesCreator()
        {
            InitialLanguages = new List<ApplicationLanguage>
            {
                new ApplicationLanguage(null, "en", "English", "famfamfam-flags gb"),
                new ApplicationLanguage(null, "ar", "العربية", "famfamfam-flags sa"),
                new ApplicationLanguage(null, "de", "German", "famfamfam-flags de"),
                new ApplicationLanguage(null, "it", "Italiano", "famfamfam-flags it"),
                new ApplicationLanguage(null, "pt-BR", "Portuguese", "famfamfam-flags br"),
                new ApplicationLanguage(null, "tr", "Türkçe", "famfamfam-flags tr"),
                new ApplicationLanguage(null, "ru", "Русский", "famfamfam-flags ru"),
                new ApplicationLanguage(null, "zh-CN", "简体中文", "famfamfam-flags cn")
            };
        }

        public DefaultLanguagesCreator(AbpZeroTemplateDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateLanguages();
        }

        private void CreateLanguages()
        {
            foreach (var language in InitialLanguages)
            {
                AddLanguageIfNotExists(language);
            }
        }

        private void AddLanguageIfNotExists(ApplicationLanguage language)
        {
            if (_context.Languages.Any(l => l.TenantId == language.TenantId && l.Name == language.Name))
            {
                return;
            }

            _context.Languages.Add(language);

            _context.SaveChanges();
        }
    }
}