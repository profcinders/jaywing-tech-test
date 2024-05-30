import fs from "node:fs";
import { src, dest, watch, series } from "gulp";
import postcss from "gulp-postcss";
import tailwindcss from "tailwindcss";
import autoprefixer from "autoprefixer";

const watchFiles = "../JaywingTechTest.Web/Views/**/*.cshtml";
const stylesEntry = "./src/styles/main.css";
const assetsDest = "../JaywingTechTest.Web/wwwroot/assets";

const clean = (cb) => fs.rm(assetsDest, { recursive: true, force: true }, cb);

const buildStyles = () =>
	src(stylesEntry)
		.pipe(postcss([tailwindcss, autoprefixer]))
		.pipe(dest(assetsDest));

const watchStyles = () => watch([watchFiles, stylesEntry], buildStyles);

export const dev = series(clean, buildStyles, watchStyles);
export const deploy = series(clean, buildStyles);
export default deploy;
