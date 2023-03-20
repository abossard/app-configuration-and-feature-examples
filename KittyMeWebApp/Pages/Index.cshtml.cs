using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.FeatureManagement;

namespace KittyMeWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly Settings _settings;
        private readonly IFeatureManager _featureManager;

        public IndexModel(ILogger<IndexModel> logger, IOptionsSnapshot<Settings> settings, IFeatureManager featureManager)
        {
            _logger = logger;
            _settings = settings.Value;
            _featureManager = featureManager;
        }

        public void OnGet()
        {
            ViewData["BackgroundColor"] = _settings.BackgroundColor;
            ViewData["BackgroundUrl"] = _settings.BackgroundUrl;
            ViewData["FontSize"] = _settings.FontSize;
            ViewData["FontColor"] = _settings.FontColor;
            ViewData["Message"] = _settings.Message;
            ViewData["SoundUrl"] = _settings.SoundUrl;
            ViewData["SoundLabel"] = _settings.SoundLabel;
        }
    }
}

