﻿using System;
using System.Collections.Generic;
using Crowdin.Api.Protocol;

namespace Crowdin.Api.Typed
{
    public sealed class ExportTranslationCostsReportParameters
    {
        public ReportUnit? Unit { get; set; }

        public ReportMode? Mode { get; set; }

        [Property("date_from")]
        public DateTime? DateFrom { get; set; }

        [Property("date_to")]
        public DateTime? DateTo { get; set; }

        [Property("regular_rates")]
        public IDictionary<String, String> RegularRates { get; set; }

        [Property("individual_rates")]
        public IDictionary<String, String> IndividualRates { get; set; }

        public String Currency { get; set; }

        public String Format { get; set; }

        [Property("role_based_costs")]
        public Boolean? RoleBased { get; set; }

        [Property("group_by")]
        public String GroupBy { get; set; }
    }
}