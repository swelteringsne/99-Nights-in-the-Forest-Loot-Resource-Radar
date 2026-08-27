-- Build: 9eff2e8d380e3b9e48c1b87fcb392b10
local M = {}

function M.clamp(value, minimum, maximum)
  return math.max(minimum, math.min(maximum, value))
end

return M
