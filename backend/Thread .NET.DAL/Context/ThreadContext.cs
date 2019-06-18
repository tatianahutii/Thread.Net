﻿using Microsoft.EntityFrameworkCore;
using Thread_.NET.DAL.Entities;

namespace Thread_.NET.DAL.Context
{
    public sealed class ThreadContext : DbContext
    {
        public ThreadContext(DbContextOptions<ThreadContext> options) : base(options) { }

        public DbSet<Comment> Comments { get; private set; }
        public DbSet<CommentReaction> CommentReactions { get; private set; }
        public DbSet<DisCommentReaction> DisCommentReactions { get; private set; }
        public DbSet<Image> Images { get; private set; }
        public DbSet<Post> Posts { get; private set; }
        public DbSet<PostReaction> PostReactions { get; private set; }
        public DbSet<DisPostReaction> DisPostReactions { get; private set; }
        public DbSet<RefreshToken> RefreshTokens { get; private set; }
        public DbSet<User> Users { get; private set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Setting up entities using extension method
            modelBuilder.Configure();

            // Seeding data using extension method
            // NOTE: this method will be called every time after adding a new migration, cuz we use Bogus for seed data
            modelBuilder.Seed();
        }
    }
}
