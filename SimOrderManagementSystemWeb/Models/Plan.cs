using System;

namespace SimOrderManagementSystemWeb.Models;

public class Plan
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public List<PlanBenefit> PlanBenefits { get; set; }
}