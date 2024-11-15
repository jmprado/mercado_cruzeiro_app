module.exports = {
  presets: [
    'module:@react-native/babel-preset',
  ],
  env: {
    production: {
      plugins: [
        'react-native-paper/babel',
        ['@babel/plugin-transform-private-method', { loose: true }],
        ['@babel/plugin-transform-private-property-in-object', { loose: true }],
      ],
    },
  },
};
