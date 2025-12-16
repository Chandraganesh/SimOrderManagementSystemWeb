using System;
using SimOrderManagementSystemWeb.Enums;

namespace SimOrderManagementSystemWeb.Models;

public class PlanBenefit
{
    public int Id { get; set; }
    public PlanBenefitType BenefitType { get; set; }
    public string Name { get; set; }
    public double Value { get; set; }
}