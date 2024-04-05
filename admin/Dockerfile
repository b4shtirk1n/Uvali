FROM node:current-alpine as build
WORKDIR /app
COPY . .
RUN corepack enable
RUN pnpm install && pnpm run build

FROM nginx:alpine
COPY --from=build /app/dist /usr/share/nginx/html
CMD ["nginx", "-g", "daemon off;"]