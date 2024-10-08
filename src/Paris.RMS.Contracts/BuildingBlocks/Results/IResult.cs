﻿namespace Paris.RMS.Contracts.BuildingBlocks.Results;

public interface IResult<out TValue> : IResult
{
    TValue Value { get; }
}

public interface IResult
{
    bool IsSuccess { get; }

    bool IsFailure { get; }

    Error Error { get; }
}
