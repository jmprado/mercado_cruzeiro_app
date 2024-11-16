const isValidEmail = /^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$/g;

const validateEmail = (value: string): boolean => {
  return !!(value && value.match(isValidEmail));
};

export { validateEmail };
