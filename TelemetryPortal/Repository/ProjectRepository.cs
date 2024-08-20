using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TelemetryPortal.Data;
using TelemetryPortal.Models;  

namespace TelemetryPortal.Repository
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        private readonly TechtrendsContext _context;

        // Constructor to inject the database context
        public ProjectRepository(TechtrendsContext context) : base(context)
        {
            _context = context;
        }

        // Get all projects
        public async Task<IEnumerable<Project>> GetAll()
        {
            return await _context.Projects.ToListAsync();
        }

        // Get a single project by ID
        public async Task<Project> Get(Guid projectId)
        {
            return await _context.Projects.FindAsync(projectId) ?? new Project();

        }

            // Create a new project
            public async Task Create(Project project)
        {
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();
        }

        // Update an existing project
        public async Task Update(Project project)
        {
            _context.Entry(project).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        // Delete a project by ID
        public async Task Delete(Guid projectId)
        {
            var project = await _context.Projects.FindAsync(projectId);
            if (project != null)
            {
                _context.Projects.Remove(project);
                await _context.SaveChangesAsync();
            }
        }
    }
}
