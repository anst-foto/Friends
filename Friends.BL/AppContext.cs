﻿using Friends.BL.Models;
using Friends.DAL;

namespace Friends.BL;

public class AppContext
{
    private readonly IContext<DAL.Models.Friend> _context;

    public AppContext(IContext<DAL.Models.Friend> context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Friend>?> GetFriendsAsync()
    {
        await _context.LoadAsync();
        return _context.Friends?.Select(Mapper.MapFriendDalToFriendBl);
    }
}